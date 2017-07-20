using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Siotrix
{
    public class Tag : Entity
    {
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
        public ulong OwnerId { get; private set; }
        public ulong GuildId { get; private set; }
        public string Content { get; private set; }
        public string Names
        {
            get { return JsonConvert.SerializeObject(Aliases); }
            set { Aliases = JsonConvert.DeserializeObject<List<string>>(value); }
        }

        [NotMapped]
        public List<string> Aliases { get; private set; }

        // Foreign Keys
        public List<TagLog> Logs { get; private set; }

        public Tag() { }
        public Tag(string name, string content, ulong guildId, ulong ownerId)
        {
            Aliases = new List<string> { name };
            Content = content;
            GuildId = guildId;
            OwnerId = ownerId;
        }

        internal void ResetUpdatedAt()
            => UpdatedAt = DateTime.UtcNow;

        public void SetOwnerId(ulong ownerId)
        {
            OwnerId = ownerId;
            ResetUpdatedAt();
        }

        public void SetContent(string content)
        {
            Content = content;
            ResetUpdatedAt();
        }

        public void AddNames(string[] names)
        {
            Aliases.AddRange(names);
            ResetUpdatedAt();
        }

        public void RemoveNames(string[] names)
        {
            foreach (var name in names)
                Aliases.Remove(name);
            ResetUpdatedAt();
        }
    }
}
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
        public long OwnerId { get; private set; }
        public long GuildId { get; private set; }
        public string Content { get; private set; }
        public string Name { get; private set; }

        // Foreign Keys
        public List<TagLog> Logs { get; private set; }

        public Tag() { }
        public Tag(string name, string content, long guildId, long ownerId)
        {
            Name = name;
            Content = content;
            GuildId = guildId;
            OwnerId = ownerId;
        }

        internal void ResetUpdatedAt()
            => UpdatedAt = DateTime.UtcNow;

        public void SetOwnerId(long ownerId)
        {
            OwnerId = ownerId;
            ResetUpdatedAt();
        }

        public void SetContent(string content)
        {
            Content = content;
            ResetUpdatedAt();
        }
    }
}
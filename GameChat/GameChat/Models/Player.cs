using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameChat.Models
{
    public class Player
    {
        [Key]
        [MaxLength(30), MinLength(2)]
        public String UserName { get; set; } //navgtion property 


        public ICollection<PlayerMessage> sentMessages { get; set; }
    }

    public class PlayerMessage
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Player")]
        public string PlayersUsername { get; set; }

        public Player Player { get; set; }

        [Required]
        [MaxLength(30), MinLength(2)]
        public string Username { get; set; }

        [Required]
        public string MessageSent { get; set; }

        [Required]
        public DateTime DateSent { get; set; }
    }

    public class ChatContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerMessage> Messages { get; set; }

        public ChatContext() :
         base("ChatDB")
        {

        }
    }

}
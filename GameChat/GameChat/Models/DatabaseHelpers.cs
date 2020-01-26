using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameChat.Models
{
    public static class DatabaseHelpers
    {
        public static ChatContext CreateContext()
        {
            return new ChatContext();
        }

        public static Player findPlayer(string username)
        {
            using (var context = CreateContext())
            {
                return context.Players.Find(username);
            }
        }

        public static void AddPlayerMessage(PlayerMessage message)
        {
            using (var context = CreateContext())
            {
                context.Messages.Add(message);
            }
        }

        public static List<PlayerMessage> findAllPlayerMessages(string username)
        {
            using (var context = CreateContext())
            {
                return context.Messages.Where(m => m.PlayersUsername == username).ToList();
            }
        }
    }
}
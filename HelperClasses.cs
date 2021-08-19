﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsLeaderboard
{
    public class HelperClasses
    {
    }

    public class UserScore
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }

        public int MessageCount { get; set; }
        public int MessageWithSubjectCount { get; set; }
        public int ReplyCount { get; set; }
        public int ReactionCount { get; set; }

        public UserScore(string id, string displayName, int score)
        {
            UserId = id;
            UserName = displayName;
            CountScore(score);
        }
        
        public void CountScore(int score)
        {
            Score += score;
            
            switch(score)
            {
                case ScoringModell.CHAT_MESSAGE:
                    MessageCount++;
                    break;
                case ScoringModell.CHATMESSAGE_WITH_SUBJECT:
                    MessageWithSubjectCount++;
                    break;
                case ScoringModell.REACTION:
                    ReactionCount++;
                    break;
                case ScoringModell.REPLY:
                    ReplyCount++;
                    break;
                default:
                    break;
            }
        }
    }

    public class ScoringModell
    {
        public const int CHAT_MESSAGE = 5;
        public const int CHATMESSAGE_WITH_SUBJECT = 7;
        public const int REPLY = 3;
        public const int REACTION = 1;
    }
}

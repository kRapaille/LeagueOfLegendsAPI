namespace PortableLeagueApi.Interfaces.Enums
{
    public enum QueueTypeEnum
    {
        CUSTOM,                     //	Custom games
        NORMAL_5x5_BLIND,           //		Normal 5v5 Blind Pick games
        BOT_5x5,                    //		Historical Summoner's Rift Coop vs AI games
        BOT_5x5_INTRO,              //		Summoner's Rift Coop vs AI Intro Bot games
        BOT_5x5_BEGINNER,           //		Summoner's Rift Coop vs AI Beginner Bot games
        BOT_5x5_INTERMEDIATE,       //		Historical Summoner's Rift Coop vs AI Intermediate Bot games
        NORMAL_3x3,                 //		Normal 3v3 games
        NORMAL_5x5_DRAFT,           //		Normal 5v5 Draft Pick games
        ODIN_5x5_BLIND,             //		Dominion 5v5 Blind Pick games
        ODIN_5x5_DRAFT,             //		Dominion 5v5 Draft Pick games
        BOT_ODIN_5x5,               //		Dominion Coop vs AI games
        RANKED_SOLO_5x5,            //		Ranked Solo 5v5 games
        RANKED_PREMADE_3x3,         //		Ranked Premade 3v3 games
        RANKED_PREMADE_5x5,         //		Ranked Premade 5v5 games
        RANKED_TEAM_3x3,            //		Ranked Team 3v3 games
        RANKED_TEAM_5x5,            //		Ranked Team 5v5 games
        BOT_TT_3x3,                 //		Twisted Treeline Coop vs AI games
        GROUP_FINDER_5x5,           //		Team Builder games
        ARAM_5x5,                   //		ARAM games
        ONEFORALL_5x5,              //		One for All games
        FIRSTBLOOD_1x1,             //		Snowdown Showdown 1v1 games
        FIRSTBLOOD_2x2,             //		Snowdown Showdown 2v2 games
        SR_6x6,                     //		Hexakill games
        URF_5x5,                    //		Ultra Rapid Fire games
        BOT_URF_5x5,                //		Ultra Rapid Fire games played against AI games
        NIGHTMARE_BOT_5x5_RANK1,    //		Doom Bots Rank 1 games
        NIGHTMARE_BOT_5x5_RANK2,    //		Doom Bots Rank 2 games
        NIGHTMARE_BOT_5x5_RANK5,    //		Doom Bots Rank 5 games
        ASCENSION_5x5,              //		Ascension games
    }
}
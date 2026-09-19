namespace GolBet.Services.DTOs;

public class MatchDetailDto : MatchDto

{

    /// <summary>How many bets have been placed on this match.</summary> 

    public int TotalBets { get; set; }

}
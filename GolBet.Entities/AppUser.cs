using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GolBet.Entities;

public class AppUser : IdentityUser

{

    [MaxLength(100)]

    public string FullName { get; set; } = null!;



    /// <summary>Virtual currency balance (FutCoins).</summary> 

    public decimal Balance { get; set; }



    public ICollection<Bet> Bets { get; set; } = new List<Bet>();

}

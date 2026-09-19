
// GolBet.Services/Implementations/MatchService.cs
using GolBet.Entities.Enums;
using GolBet.Repositories.Interfaces;
using GolBet.Services.Interfaces;
using GolBet.Services.DTOs;
using AutoMapper;

namespace GolBet.Services.Implementations;

public class MatchService : IMatchService
{
    private readonly IMatchRepository _matchRepository;
    private readonly IMapper _mapper;

    public MatchService(IMatchRepository matchRepository, IMapper mapper)
    {
        _matchRepository = matchRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<MatchDto>> GetBoardAsync(MatchStatus? status = null)
    {
        var matches = await _matchRepository.GetAllWithTeamsAsync(status);
        return _mapper.Map<IEnumerable<MatchDto>>(matches);
    }
}

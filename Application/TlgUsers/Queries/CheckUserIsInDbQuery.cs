﻿using Application.TlgUsers.Interfaces;

namespace Application.TlgUsers.Queries;

public class CheckUserIsInDbQuery : ICheckUserIsInDbQuery
{
    private readonly IDatingBotDbContext _context;

    public CheckUserIsInDbQuery(IDatingBotDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CheckUserIsInDbAsync(long chatId)
    {
        var entity = await _context.TlgUsers
            .SingleOrDefaultAsync(u => u.ChatId == chatId);

        if (entity == null) return false;
        else return true;
    }
}

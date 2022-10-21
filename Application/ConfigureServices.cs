﻿using Application.DatingUsers.Commands;
using Application.DatingUsers.Interfaces;
using Application.DatingUsers.Queries;
using Application.Photos.Commands;
using Application.Photos.Interfaces;
using Application.Photos.Queries;
using Application.TlgUsers.Commands;
using Application.TlgUsers.Interfaces;
using Application.TlgUsers.Queries;


namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateTlgUserCommand, CreateTlgUserCommand>();
        services.AddScoped<ICheckUserIsInDbQuery, CheckUserIsInDbQuery>();
        services.AddScoped<ICreateDatingUserCommand, CreateDatingUserCommand>();
        services.AddScoped<IGetDatingUserQuery, GetDatingUserQuery>();
        services.AddScoped<IUpdateDatingUserCommand, UpdateDatingUserCommand>();
        services.AddScoped<IGetAdminsChatIdQuery, GetAdminsChatIdQuery>();
        services.AddScoped<ICreatePhotoCommand, CreatePhotoCommand>();
        services.AddScoped<IDeletePhotoCommand, DeletePhotoCommand>();
        services.AddScoped<IUpdatePhotoCommand, UpdatePhotoCommand>();
        services.AddScoped<ICheckUserHasPhotosQuery, CheckUserHasPhotosQuery>();
        services.AddScoped<IGetPhotosQuery, GetPhotosQuery>();

        return services;
    }
}

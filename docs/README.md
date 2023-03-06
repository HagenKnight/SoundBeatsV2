### Migrations

```console
dotnet ef migrations add InitialModel --context SoundBeatsDbContext --project ../SoundBeats.Infrastructure.Persistence/SoundBeats.Infrastructure.Persistence.csproj --startup-project ../SoundBeats.Api/SoundBeats.Api.csproj --output-dir Data/Migrations --verbose
```

### Update EF

```console
dotnet ef database update --context SoundBeatsDbContext --project ../SoundBeats.Infrastructure.Persistence/SoundBeats.Infrastructure.Persistence.csproj --startup-project ../SoundBeats.Api/SoundBeats.Api.csproj --verbose
```


### Identity Migrations

### Execution for Initial snapshot
```console
dotnet ef migrations add InitialIdenity --context SoundBeatsIdentityDbContext --project ../SoundBeats.Identity/SoundBeats.Identity.csproj --startup-project ../SoundBeats.Api/SoundBeats.Api.csproj --output-dir Data/Migrations --verbose
```

### Update EF
```console
dotnet ef database update --context SoundBeatsIdentityDbContext --project ../SoundBeats.Identity/SoundBeats.Identity.csproj --startup-project ../SoundBeats.Api/SoundBeats.Api.csproj --verbose
```


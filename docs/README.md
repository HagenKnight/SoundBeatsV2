## Migrations

dotnet ef migrations add InitialModel --context SoundBeatsDbContext --project ../SoundBeats.Infrastructure.Persistence/SoundBeats.Infrastructure.Persistence.csproj --startup-project ../SoundBeats.Api/SoundBeats.Api.csproj --output-dir Data/Migrations --verbose

## Update EF
dotnet ef database update --context SoundBeatsDbContext --project ../SoundBeats.Infrastructure.Persistence/SoundBeats.Infrastructure.Persistence.csproj --startup-project ../SoundBeats.Api/SoundBeats.Api.csproj --verbose


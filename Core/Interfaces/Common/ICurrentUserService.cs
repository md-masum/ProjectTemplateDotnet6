namespace Core.Interfaces.Common
{
    public interface ICurrentUserService
    {
        string? UserId { get; }
        string? UserName { get; }
        string? Email { get; }
        string? Phone { get; }
    }
}
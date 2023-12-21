namespace Actio.Common.Commands
{
    public interface IEventHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
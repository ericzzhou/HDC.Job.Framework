
namespace HDC.Job.Interface
{
    public interface IJob
    {
        void Start(JobContext context);

        void Stop(JobContext context);

        void Continue(JobContext context);

        void Pause(JobContext context);
    }
}

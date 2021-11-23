using TimeTable.Repositories;

namespace TimeTable.Data
{
    public class ProjectRepository : Repository<Project>
    {
    public ProjectRepository(TimeTableContext context) : base(context)
    {

    }
    // We can add new methods specific to the movie repository here in the future
    }
}

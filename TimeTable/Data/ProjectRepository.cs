using TimeTable.Repositories;

namespace TimeTable.Data
{
    public class EmployeeRepository : Repository<Employee>
    {
    public EmployeeRepository(TimeTableContext context) : base(context)
    {

    }
    // We can add new methods specific to the movie repository here in the future
    }
}

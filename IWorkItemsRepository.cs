using net_labs.Domain.Models;

namespace net_labs.DataAccess.Abstractions;

public interface IWorkItemsRepository
{
    Guid Add(WorkItem workItem);
    WorkItem Get(Guid id);
    IEnumerable<WorkItem> GetAll();
    bool Update(WorkItem workItem);
    bool Remove(Guid id);
    void SaveChanges();
}
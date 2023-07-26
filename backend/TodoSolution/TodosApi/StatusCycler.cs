namespace TodosApi;

public class StatusCycler : IProvideStatusCycling
{
    public TodoListItemResponseModel ProvideNextStatusFrom(TodoListItemResponseModel savedItem)
    {

        if(savedItem.Status == TodoItemStatus.Now)
        {
            return savedItem with { Status = TodoItemStatus.Waiting };
        }
        else if (savedItem.Status == TodoItemStatus.Later)
        {
            return savedItem with { Status = TodoItemStatus.Now };
        }
        else if (savedItem.Status == TodoItemStatus.Waiting)
        {
            return savedItem with { Status = TodoItemStatus.Completed };
        }
        else if (savedItem.Status == TodoItemStatus.Completed)
        {
            return savedItem with { Status = TodoItemStatus.Later };
        }
        else
        {

            return null;
        }
    }
}
namespace TaskFlowAI.Domain;

public class TaskItem
{
    public Guid Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public bool IsCompleted { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? CompletedAt { get; private set; }

    private TaskItem() { }

    // Constructor privado para forzar el uso del Factory Method
    private TaskItem(Guid id, string title, string? description)
    {
        Id = id;
        Title = title;
        Description = description;
        IsCompleted = false;
        CreatedAt = DateTime.UtcNow;
    }

    // Factory Method: Garantiza que la entidad se crea en un estado válido
    public static TaskItem Create(string title, string? description = null)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("El título de la tarea no puede estar vacío.", nameof(title));
        }

        return new TaskItem(Guid.NewGuid(), title.Trim(), description?.Trim());
    }

    // Comportamiento de la entidad: De momento dejamos esta funcionalidad basica
    public void MarkAsCompleted()
    {
        if (IsCompleted) return;

        IsCompleted = true;
        CompletedAt = DateTime.UtcNow;
    }
}


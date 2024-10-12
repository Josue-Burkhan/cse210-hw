public class Comment
{
    // Propiedades para el nombre del usuario y el texto del comentario.
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    // Constructor para inicializar el comentario con nombre y texto.
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}
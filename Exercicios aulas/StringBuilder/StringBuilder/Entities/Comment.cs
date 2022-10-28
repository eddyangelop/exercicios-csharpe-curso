namespace String_Builder.Entities
{
    class Comment
    {
        // propriedades
        public string Text { get; set; }

        // construtor padrão sem argumentos
        public Comment()
        {

        }
        // construtor com argumentos
        public Comment(string text)
        {
            Text = text;
        }

    }
}

static class User
{
    // As propriedades e métodos de uma classe estática tem de ser estáticas.
    // São acessíveis a outras classes do sistema.
    public static string Name { get; set; }
    public static string Surname { get; set; }

    public static string ShowUserName() {
        return "O nome digitado foi " + Name + " " + Surname;
    }
}
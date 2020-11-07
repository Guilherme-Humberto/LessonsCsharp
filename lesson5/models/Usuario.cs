class Usuario
{
    public string Nome { get; set; }

    // Overloading (sobrecarga)
    public void setName(string nome) {
        this.Nome = nome;
    }

    public string setName() {
        return "O nome digitado foi: " + Nome; 
    }
}
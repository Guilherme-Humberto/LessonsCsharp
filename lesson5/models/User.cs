class User
{
    public string Name { get; set; }

    // Overloading (sobrecarga)
    public void SetName(string @name) {
        this.Name = @name;
    }

    public string SetName() {
        return "O nome digitado foi: " + Name; 
    }
}
class User
{
    public string Name { get; set; }

    public void SetName(string @name) {
        this.Name = @name;
    }

    public string SetName() {
        return "O nome digitado foi: " + Name; 
    }
}

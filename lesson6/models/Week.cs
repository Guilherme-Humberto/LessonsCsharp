using System;
class Week
{   
    enum DaysOfWeek
    {
        Segunda_Feira, 
        Terça_Feira, 
        Quarta_Feira
    }

    public void DaySelected() {
        Console.Write(DaysOfWeek.Segunda_Feira);
    }
}
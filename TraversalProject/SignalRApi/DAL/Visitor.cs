namespace SignalRApi.DAL;


public enum ECity
{
    Edirne = 1,
    Istanbul,
    Ankara,
    Antalya,
    Bursa
}

public class Visitor
{
    public int VisitorId { get; set; }
    public ECity City { get; set; }
    public int CityVisitCount { get; set; }
    public DateTime VisitDate { get; set; }
}
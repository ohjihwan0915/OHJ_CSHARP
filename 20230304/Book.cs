
public class Book
{
        
    public int price;
    public int page;
    public string title="";
    public int year;
    public void getinfo(){
        Console.WriteLine($"{title} 은 {year} 에 발행된 {this.price}에 판매되고 있는 {page}페이지의 책입니다");
    }
}

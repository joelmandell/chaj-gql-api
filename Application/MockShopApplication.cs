public class MockShopApplication : IShopApplication
{
    public User CurrentUser {get;set;}
    public IUserStore UserStore {get;set;}

    public MockShopApplication() {
        this.UserStore = new MockUserStore();
        this.CurrentUser = new User() {
            ID=3,
            Name="Steve Ballmer"
        };
    }
}

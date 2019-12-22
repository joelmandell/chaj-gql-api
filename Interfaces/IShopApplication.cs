public interface IShopApplication {
    public User CurrentUser { get; set; }
    public IUserStore UserStore { get; set; }
}
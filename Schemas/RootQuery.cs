using GraphQL.Types;

public class RootQuery : ObjectGraphType {
    public RootQuery() {
        this.Name = "RootQuery";

        Field<StringGraphType>("me",description:"Information about current logged in user",resolve:ctx => {
            return AppContainer.MockShopApp.CurrentUser;
        });

        Field<ListGraphType<UserType>>("users",resolve:ctx => {
            var users = AppContainer.MockShopApp.UserStore.GetUsers();
            return users;
        });
    }
}
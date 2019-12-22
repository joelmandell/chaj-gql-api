using GraphQL.Types;

public class UserType : ObjectGraphType<User> {
    public UserType() {
        Name = "UserType";
        Description = "User information";
        Field(x => x.ID).Description("The User ID");
        Field(x => x.Name).Description("The user name");
        Field(x => x.Email).Description("The user email adress.");
    }
}
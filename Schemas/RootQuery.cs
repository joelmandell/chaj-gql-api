using GraphQL.Types;

public class RootQuery : ObjectGraphType {
    public RootQuery() {
        this.Name = "RootQuery";

        Field<StringGraphType>("me",description:"Information about current logged in user",resolve:ctx => {
            return UserStore.Name;
        });
    }
}

public class UserType : ObjectGraphType {
    public UserType() {
        Name = "UserType";
        Description = "User information";
        Field<StringGraphType>("name",description:"The user name");
        Field<StringGraphType>("email",description:"The user email adress.");
    }
}

public class User {
    public string Name  { get; set; }
    public string Email { get; set; }
}
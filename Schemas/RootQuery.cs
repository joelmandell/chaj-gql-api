using GraphQL.Types;

public class RootQuery : ObjectGraphType {
    public RootQuery() {
        this.Name = "RootQuery";

        Field<StringGraphType>("me",description:"Information about current logged in user",resolve:ctx => {
            var foo = ctx.Arguments["testing"];
            return UserStore.Name + " " +foo;
        },arguments:new QueryArguments() { 
            new QueryArgument<StringGraphType> {Name = "testing",DefaultValue="bar baz"}
        });
    }
}

public class UserType : ObjectGraphType<User> {
    public UserType() {
        Name = "UserType";
        Description = "User information";
        Field(x => x.Name).Description("The user name");
        Field(x => x.Email).Description("The user email adress.");
    }
}

public class User {
    public string Name  { get; set; }
    public string Email { get; set; }
}
using GraphQL.Types;

public class UserInputType : InputObjectGraphType<User> {
    public UserInputType() {
        Name = "UserInputType";

        Field(x => x.ID);
        Field(x => x.Name);
        Field(x => x.Email);
    }
}
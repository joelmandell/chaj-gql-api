using GraphQL.Types;

public class RootMutation : ObjectGraphType {
    public RootMutation() {
        this.Name = "RootMutation";

        Field<StringGraphType>("updateMe",description:"Mutate current user",resolve:ctx => {
            UserStore.Name = "Awesome Coder is mutated";
           return UserStore.Name;
        });
    }
}
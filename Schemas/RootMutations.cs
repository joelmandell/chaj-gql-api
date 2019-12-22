using System.Linq;
using GraphQL.Types;

public class RootMutation : ObjectGraphType {
    public RootMutation() {
        this.Name = "RootMutation";

        Field<StringGraphType>("updateMe",description:"Mutate current user",resolve:ctx => {
            UserStore.Name = "Awesome Coder is mutated";
           return UserStore.Name;
        });

        Field<UserType>("updateUser",resolve:ctx => {
            var id = ctx.GetArgument<int>("id");
            var user = ctx.GetArgument<User>("user");

            var currentUser = AppContainer.MockShopApp.UserStore.UpdateUser(id,user);
            
            currentUser = user;
            return user;
        },arguments:new QueryArguments() {
            new QueryArgument<IntGraphType> { Name="id"},
            new QueryArgument<UserInputType> { Name="user"}
        });

        Field<UserType>("createUser",resolve:ctx => {
            var user = ctx.GetArgument<User>("user");
            AppContainer.MockShopApp.UserStore.CreateUser(user);
            return user;
        },arguments:new QueryArguments() {
            new QueryArgument<UserInputType> { Name="user"}
        });

        Field<UserType>("deleteUser",resolve:ctx => {
            var id = (int)ctx.Arguments["id"];
            return AppContainer.MockShopApp.UserStore.DeleteUser(id);
        },arguments:new QueryArguments() {
            new QueryArgument<IntGraphType> { Name="id"}
        });
    }
}
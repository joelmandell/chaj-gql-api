using GraphQL;

public class GraphQLQuery {
    public string query { get; set; }
    public Inputs variables { get; set; }
    public string operationName { get; set; }
}
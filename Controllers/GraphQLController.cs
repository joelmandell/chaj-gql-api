using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GraphQL;
using GraphQL.Types;

namespace gql_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GraphQLController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery post)
        {
            //We gonna add a schema
            //We are going to attach root query to this schema.

            var docEx = await new DocumentExecuter().ExecuteAsync(_=> {
                _.Schema = new Schema() { Query = new RootQuery(),Mutation=new RootMutation()};
                _.Query = post.query;
                _.Inputs = post.variables;
                _.OperationName = post.operationName;
            });

            return Ok(new {Data=docEx.Data});
        }
    }
}

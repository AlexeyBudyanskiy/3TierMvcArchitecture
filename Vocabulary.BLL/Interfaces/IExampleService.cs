using System.Collections.Generic;
using Vocabulary.BLL.DTO;

namespace Vocabulary.BLL.Interfaces
{
    public interface IExampleService
    {
        ExampleDto Get(int id);
        IEnumerable<ExampleDto> GetAll();
        void Create(ExampleDto exampleDto);
        void Edit(ExampleDto exampleDto);
        void Delete(int id);
    }
}

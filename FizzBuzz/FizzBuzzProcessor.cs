using FizzBuzz.Interfaces;

namespace FizzBuzz
{
    public class FizzBuzzProcessor
    {
        private readonly IFizzBuzzService _fizzBuzzService;
        private readonly IFizzBuzzData _repository;

        public FizzBuzzProcessor(IFizzBuzzService fizzBuzzService, IFizzBuzzData repository)
        {
            _fizzBuzzService = fizzBuzzService;
            _repository = repository;
        }

        public void Process()
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = _fizzBuzzService.GetFizzBuzzResult(i);
                Console.WriteLine(result);
                _repository.StoreResult(i, result);
            }
        }
    }
}

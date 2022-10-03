using MediatR;

namespace MediatrExample.Med.Commands
{
    public class CreatedProductCommand: IRequest<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public class CreateProductCommandHandler : IRequestHandler<CreatedProductCommand, Guid>
        {
            public Task<Guid> Handle(CreatedProductCommand request, CancellationToken cancellationToken)
            {
                return Task.FromResult(Guid.NewGuid());
            }
        }
    }
}

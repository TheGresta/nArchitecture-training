using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Brands.Commands.CreateBrand
{
    public class BaseHandler<TRequest, TResponse, TRepository, TRule> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>, new()
    {
        //public Func<TRequest, TResponse> handle;
        protected readonly TRepository _tRepository;
        protected readonly IMapper _mapper;
        protected readonly TRule _tRele;

        public BaseHandler(TRepository tRepository, IMapper mapper, TRule tRele)
        {
            _tRepository = tRepository;
            _mapper = mapper;
            _tRele = tRele;
        }
        public virtual Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}

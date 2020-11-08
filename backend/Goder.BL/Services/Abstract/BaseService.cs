using AutoMapper;
using Goder.DAL.Context;

namespace Goder.BL.Services.Abstract
{
    public abstract class BaseService
    {
        protected readonly GoderContext _context;
        protected readonly IMapper _mapper;

        public BaseService(GoderContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}

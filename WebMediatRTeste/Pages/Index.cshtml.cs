using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRTeste.Domain.Command;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebMediatRTeste.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMediator _mediator;
        public IndexModel(ILogger<IndexModel> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
            var notification = _mediator.Send(new InserirClienteCommand { Email = "luiz@cesgranrio.org.br", Nome = "Luiz" });
        }

        public void OnGet()
        {

        }
    }
}

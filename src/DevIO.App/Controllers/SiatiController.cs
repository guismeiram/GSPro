using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Bussines.interfaces;
using DevIO.Bussines.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thinktecture.IdentityModel.Authorization.Mvc;

namespace DevIO.App.Controllers
{
    [Authorize]
    public class SiatiController : Controller
    {
        private readonly IRepositorySiati<Siati> _repository;
        private readonly IMapper _mapper;
        public Siati _siati;
        public SiatiController(IRepositorySiati<Siati> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [Route("lista-de-siatis")]
        // GET: Siati
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<SiatiViewModel>>(await _repository.ObterTodos()));
        }

        [AllowAnonymous]
        [Route("dados-do-siatis/{id:guid}")]
        // GET: Siati/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var siatiViewModel = _mapper.Map<SiatiViewModel>(await _repository.ObterPorId(id));

            if (siatiViewModel == null)
            {
                return NotFound();
            }
            return View(siatiViewModel);
        }

        [ClaimsAuthorize("Siati", "Adicionar")]
        [Route("novo-siati")]
        // GET: Siati/Create
        public IActionResult Create()
        {
            return View();
        }

        [ClaimsAuthorize("Siati", "Adicionar")]
        [Route("novo-siati")]
        [HttpPost]
        public async Task<IActionResult> Create(SiatiViewModel siatiViewModel)
        {
            if (!ModelState.IsValid) return View(siatiViewModel);

            var siati = _mapper.Map<Siati>(siatiViewModel);
            await _repository.Adicionar(siati);

            return RedirectToAction(actionName: nameof(Index));
        }

        [ClaimsAuthorize("Siati", "Editar")]
        [Route("editar-siati/{id:guid}")]
        // GET: Siati/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var siatiViewModel = _mapper.Map<SiatiViewModel>(await _repository.ObterPorId(id));
            if (siatiViewModel == null)
            {
                return NotFound();
            }
            return View(siatiViewModel);
        }

        [ClaimsAuthorize("Siati", "Editar")]
        [Route("editar-siati/{id:guid}")]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, SiatiViewModel siatiViewModel)
        {
            if (id != siatiViewModel.Id) return NotFound();

            var siatiAtualizacao = await _repository.ObterPorId(id);
            
            if (!ModelState.IsValid) return View(siatiViewModel);

            
            siatiAtualizacao.NomeProcesso = siatiViewModel.NomeProcesso;
            siatiAtualizacao.NomeUser = siatiViewModel.NomeUser;
            siatiAtualizacao.NumeroProcesso = siatiViewModel.NumeroProcesso;
            siatiAtualizacao.Resolucao = siatiViewModel.Resolucao;
            siatiAtualizacao.Resolvido = siatiViewModel.Resolvido;
            siatiAtualizacao.TipoProcesso = siatiViewModel.TipoProcesso;
            siatiAtualizacao.DataCriacaoProcesso = siatiViewModel.DataCriacaoProcesso;


            await _repository.Atualizar(_mapper.Map<Siati>(siatiAtualizacao));

            return RedirectToAction("Index");

        }
        [ClaimsAuthorize("Siati", "Excluir")]
        [Route("excluir-siati/{id:guid}")]
        // GET: Siati/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var siatiViewModel = _mapper.Map<SiatiViewModel>(await _repository.ObterPorId(id));

            return View(siatiViewModel);
        }

        [ClaimsAuthorize("Siati", "Excluir")]
        [Route("excluir-siati/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var fornecedor = await _repository.ObterPorId(id);

            if (fornecedor == null) return NotFound();

            await _repository.Remover(id);

            return RedirectToAction("Index");

        }

       /* [HttpPost]
        public async Task<IActionResult> ExportExcel(IFormFile file)
        {
            FileDetails fileDetails;
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                var fileContent = reader.ReadToEnd();
                var parsedContentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                fileDetails = new FileDetails
                {
                    FileName  = parsedContentDisposition.FileName,
                    Content = fileContent
                };
            }

            return fileDetails;

            //return View();
        }*/
    }
}

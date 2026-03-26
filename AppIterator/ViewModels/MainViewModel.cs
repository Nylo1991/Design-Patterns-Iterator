using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AppIterator.Commands;
using AppIterator.Services;

namespace AppIterator.ViewModels
{ public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ProdutoService _service;
        public ObservableCollection<string> Logs { get; set; } = new();
        public RelayCommand ExecutarCommand { get; }
        public MainViewModel()
        {
            _service = new ProdutoService();

            ExecutarCommand = new RelayCommand(async _ => await ExecutarIteratorVisual());
        }

        //SIMULAÇÃO VISUAL DO ITERATOR
        public async Task ExecutarIteratorVisual()
        {
            Logs.Clear();

            foreach (var produto in _service.ObterProdutos()) //USANDO O ITERATOR
            {
                Logs.Add($"Iterando... : {produto.Nome}");
                await Task.Delay(1500);

                Logs.Add($"Usando: {produto.Nome} ok");
                await Task.Delay(500);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
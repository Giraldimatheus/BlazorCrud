using System.Net.Http.Json;

public interface IEmpresasServices
{
    IReadOnlyList<Class1> Empresas { get; }

    Task GetEmpresasDataAsync();
}

public class EmpresasServices : IEmpresasServices
{
    private List<Class1> _empresas = new List<Class1>();
    public IReadOnlyList<Class1> Empresas => _empresas.AsReadOnly();

    private readonly HttpClient _http;

    public EmpresasServices(HttpClient http)
    {
        _http = http;
    }

    public async Task GetEmpresasDataAsync()
    {
        _empresas = await _http.GetFromJsonAsync<List<Class1>>("https://nocodebackend.azurewebsites.net/api/v1/dataset/6426ebef76204041752bec09/611ed902fd5915f2ae005dbb?apiKey=6426ebd376204041752bec06");
    }
}

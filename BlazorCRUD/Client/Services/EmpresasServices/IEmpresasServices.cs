namespace BlazorCRUD.Client.Services.EmpresasServices
{
    public interface IEmpresasServices
    {
        List<Class1> Empresa { get; set; }

        Task GetEmpresasDataAsync();
            
    }
}

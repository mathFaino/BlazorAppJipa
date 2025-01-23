using Microsoft.EntityFrameworkCore;
using ServicesBlazor.Data.DB;
using ServicesBlazor.Data.Model;

namespace ServicesBlazor.Data.Services;

public class ServicesService(AppDbContext context)
{
    public async Task<bool> AddService(ServicesModel service)
    {   
        Console.WriteLine(service.CompanyId);
        if (context.Companies.Any(c => c.Id == service.CompanyId))
        {
            context.Services.Add(service);
            int result = await context.SaveChangesAsync();
            return result > 0;
        }
        else
        {
            throw new InvalidOperationException("Invalid CompanyId.");
        }
    }

    public List<ServicesModel> GetAllServices()
    {
        return context.Services.ToList();
    }

    public async Task DeleteService(int id)
    {
        var service = context.Services.Find(id);
        if (service != null)
        {
            context.Services.Remove(service);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task UpdateService(ServicesModel service)
    {
        context.Services.Update(service);
        await context.SaveChangesAsync();
    }
    public async Task<List<CompanyModel>> GetAllCompaniesAsync()
    {
        return await context.Companies.ToListAsync();
    }
    
    public async Task<ServicesModel> GetServiceByIdAsync(int id)
    {
        return await context.Services.FindAsync(id);
    }

}

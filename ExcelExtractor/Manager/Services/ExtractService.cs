using ExcelExtractor.Manager.Interface;
using ExcelExtractor.ViewModels;
using ExcelExtractor.ExcelDbContext;

namespace ExcelExtractor.Manager.Services
{
    public class ExtractService : IExtractorService
    {
        private readonly ExcelContext _dbContext;

        public ExtractService(ExcelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ExcelModel>> SaveExcel(List<ExcelModel> models)
        {
			try
			{
				List<ExcelModel> list = new();

				foreach(var excel in models)
				{
					ExcelModel model = new ExcelModel
					{
						ExcelName = excel.ExcelName,
						ExcelValue = excel.ExcelValue
					};

					list.Add(model);
				}

				await _dbContext.AddAsync(list);

				await _dbContext.SaveChangesAsync();

				return list;

            }
			catch (Exception)
			{
				throw;
			}
        }
    }
}

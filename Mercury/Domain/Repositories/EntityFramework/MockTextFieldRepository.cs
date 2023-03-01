using Mercury.Domain.Entities;
using Mercury.Domain.Repositories.Abstract;

namespace Mercury.Domain.Repositories.EntityFramework
{
	public class MockTextFieldRepository : ITextFieldRepository
	{
		private readonly AppDbContext context;
		public MockTextFieldRepository(AppDbContext context)
		{
			this.context = context;
		}

		public void DeliteTextField(Guid id)
		{
			context.TextFields.Remove(new TextField() { Id = id});
			context.SaveChanges();
		}

		public TextField GetTextFieldByCodeWord(string codeword)
		{
			return context.TextFields.FirstOrDefault(x => x.CodeWord == codeword);
		}

		public TextField GetTextFieldById(Guid id)
		{
			return context.TextFields.FirstOrDefault(x => x.Id == id);
		}

		public IQueryable<TextField> GetTextFields()
		{
			return context.TextFields;
		}

		public void SaveTextField(TextField entity)
		{
			if (entity.Id == default)
				context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
			else
				context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
		}
	}
}

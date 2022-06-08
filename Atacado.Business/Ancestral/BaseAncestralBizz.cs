using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Business.Ancestral
{
	public abstract class BaseAncestralBizz
	{
		protected List<string> mensagens;

		public List<string> Mensagens
		{
			get { return mensagens; }
		}

		public BaseAncestralBizz()
		{
			this.mensagens = new List<string>();
		}

		public virtual bool Executar()
		{
			throw new NotImplementedException("Deixa de ser preguiçoso!!!");
		}
	}
}
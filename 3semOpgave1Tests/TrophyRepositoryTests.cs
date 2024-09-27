using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3semOpgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3semOpgave1.Tests
{
    [TestClass()]
    public class TrophyRepositoryTests
    {
        public TrophyRepository _repository = new TrophyRepository();

        [TestInitialize]
        public void TrophyRepository()
        {
            Trophy trophy1 = new Trophy("DM i Ølbong", 2015);
            Trophy trophy2 = new Trophy("DM i Ølbong", 2016);
            Trophy trophy3 = new Trophy("Svømning i lava", 2017);
            Trophy trophy4 = new Trophy("Faldskærms sabotage", 2018);
            Trophy trophy5 = new Trophy("Bordtennis", 2019);
            _repository.Add(trophy1);
            _repository.Add(trophy2);
            _repository.Add(trophy3);
            _repository.Add(trophy4);
            _repository.Add(trophy5);
        }
        

        [TestMethod()]
        public void GetTest()
        {
            IEnumerable<Trophy> trophies = _repository.Get();
            Assert.AreEqual(5, trophies.Count());

            IEnumerable<Trophy> trophyFromDM = _repository.Get(competition: "DM i Ølbong");
            Assert.AreEqual(2, trophyFromDM.Count());

            IEnumerable<Trophy> trophyFromNowhere = _repository.Get(competition: "?_?");
            Assert.AreEqual(0, trophyFromNowhere.Count());

            IEnumerable<Trophy> trophyFrom2016 = _repository.Get(year: 2016);
            Assert.AreEqual(1, trophyFrom2016.Count());
        }
        
        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.IsNull(_repository.GetById(0));
            Assert.IsNull(_repository.GetById(6));
            Assert.IsNotNull(_repository.GetById(1));
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>_repository.Add(new Trophy("", 1242)));

            _repository.Add(new Trophy("DM i kodning", 2023));
            Assert.AreEqual(6, _repository.Get().Count());

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _repository.Add(new Trophy("Fed konkurrence mand", 1969)));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _repository.Add(new Trophy("Fed konkurrence mand", 2025)));

            Trophy hackerman = new Trophy("Hacking", 2020);
            _repository.Add(hackerman);
            Assert.AreEqual(hackerman.Id, 7);
            Assert.AreEqual(_repository.Get().Count(), 7);
        }
        
        [TestMethod()]
        public void RemoveTest()
        {
            _repository.Remove(5);
            Assert.AreEqual(_repository.Get().Count(), 4);

            Trophy temesterskabet = new Trophy("Drikke te mesterskabet", 1998);
            _repository.Add(temesterskabet);
            Assert.AreEqual(6, temesterskabet.Id);

            Assert.IsNull(_repository.Remove(12321));
        }
        
        [TestMethod()]
        public void UpdateTest()
        {
            Assert.AreEqual("Fodbold", _repository.Update(1, new Trophy("Fodbold", 2010)).Competition);

            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>_repository.Update(4, new Trophy("Snydetrophy", 1337)));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _repository.Update(2, new Trophy("OL", 1999)));
        }
    }
}
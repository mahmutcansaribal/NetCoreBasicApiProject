using ApiProjectCamp.WebApi.Context;
using ApiProjectCamp.WebApi.Dtos.ContactDtos;
using ApiProjectCamp.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectCamp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto) 
        {
            Contact contact = new Contact();
            contact.ContactEmail = createContactDto.ContactEmail;
            contact.ContactAddress = createContactDto.ContactAddress;
            contact.ContactPhone = createContactDto.ContactPhone;
            contact.ContactMapLocation = createContactDto.ContactMapLocation;
            contact.ContactOpenHours = createContactDto.ContactOpenHours;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok("Ekleme işlemi b  aşarılı");
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _context.Contacts.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact contact = new Contact();
            contact.ContactID = updateContactDto.ContactID;
            contact.ContactEmail=updateContactDto.ContactEmail;
            contact.ContactAddress=updateContactDto.ContactAddress;
            contact.ContactPhone = updateContactDto.ContactPhone;
            contact.ContactMapLocation = updateContactDto.ContactMapLocation;
            contact.ContactOpenHours = updateContactDto.ContactOpenHours;
            
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok("Günceleme başarılı");
        }
    }
}

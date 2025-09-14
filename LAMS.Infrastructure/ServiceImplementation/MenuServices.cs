using LAMS.Application.Interface;
using LAMS.Application.ModelViewDto;
using LAMS.Domain.Entities;
using LAMS.Infrastructure.DataConnection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Infrastructure.ServiceImplementation
{
    public class MenuServices : IMenu
    {

        private readonly DatabaseConnection _connection;
        public MenuServices(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<MenuDto>> getMenuAsync()
        {
            try
            {
                var result = new List<MenuDto>();

                var data = await _connection.Menu
                   .Select(m => new MenuDto
                   {
                       MenuId = m.MenuId,
                       MenuName = m.MenuName,
                       Urls = m.Urls,
                       Icon = m.Icon,
                       ParentId = m.ParentId,
                       OrderView = m.OrderView,
                       Controller = m.Controller,
                       ActiveUrls= m.ActiveUrls,
                       Area= m.Area,
                       Actions= m.Actions,
                   })
                   .ToListAsync();               

                foreach (var menu in data.Where(m => m.ParentId == 0 || m.ParentId == 0).OrderBy(m => m.OrderView))
                {
                    menu.Children = data
                        .Where(m => m.ParentId == menu.MenuId)
                        .OrderBy(m => m.OrderView)
                        .ToList();

                    result.Add(menu);
                }

                return result;

            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
        }
    }
}

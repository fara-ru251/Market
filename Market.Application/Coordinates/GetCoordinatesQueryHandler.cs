using Market.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using Razorvine.Pickle;
using System.Collections;

namespace Market.Application.Coordinates
{
    public class GetCoordinatesQueryHandler : IRequestHandler<GetCoordinatesQuery, IList<List<CoordinatesVM>>>
    {

        private readonly IReadService _readService;
        private readonly string _filePath;
        private IConfiguration _configuration;

        public GetCoordinatesQueryHandler(IReadService readService, IConfiguration configuration)
        {
            this._readService = readService ?? throw new ArgumentNullException(nameof(readService));
            this._configuration = configuration;
            this._filePath = _configuration["FileNameSection"] ?? throw new ArgumentNullException("File path in appsettings.json not provided");
        }


        public async Task<IList<List<CoordinatesVM>>> Handle(GetCoordinatesQuery request, CancellationToken cancellationToken)
        {
            var byte_arr = await this._readService.ReadAsync(Path.Combine(Directory.GetCurrentDirectory(), _filePath));

            var unpickler = new Unpickler();

            ArrayList list = null;
            try
            {
                object result = unpickler.loads(byte_arr);
                //WARNING
                list = (ArrayList)result;
            }
            catch (PickleException pce)
            {
                throw new PickleException(pce.Message);
            }
            finally
            {
                unpickler.close();
                unpickler.Dispose();
            }

            IList<List<CoordinatesVM>> coordinates = new List<List<CoordinatesVM>>();

            if (list != null)
            {
                //DANGEROUS CODE
                for (int i = 0; i < list.Count; i++)
                {
                    var inner_out_list = new List<CoordinatesVM>();
                    var inner_list = (ArrayList)list[i];

                    for (int j = 0; j < inner_list.Count; j++)
                    {

                        object[] mapping_obj_arr = (object[])inner_list[j];
                         
                        inner_out_list.Add(mapping_obj_arr);
                    }
                    coordinates.Add(inner_out_list);
                }
            }

            return await Task.FromResult(coordinates);
        }
    }
}

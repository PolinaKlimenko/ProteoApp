using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using pwiz.CLI;
using pwiz.CLI.cv;
using pwiz.CLI.data;
using pwiz.CLI.msdata;
using pwiz.CLI.analysis;
using pwiz.Common.Collections;
using pwiz.MSGraph;


namespace ProteoApp
{
    public interface IFileService
    {
        List<MassSpectrum> Open(string filename);
        
    }
    /*public class ManagedDataSource : IComparable<ManagedDataSource>
    {
        public ManagedDataSource() { }

        public ManagedDataSource(SpectrumSource source)
        {
            this.source = source;

            CVID nativeIdFormat = CVID.MS_scan_number_only_nativeID_format;
            foreach (SourceFile f in source.MSDataFile.fileDescription.sourceFiles)
            {
                // the first one in the list isn't necessarily useful - could be Agilent MSCalibration.bin or the like
                nativeIdFormat = f.cvParamChild(CVID.MS_native_spectrum_identifier_format).cvid;
                if (CVID.MS_no_nativeID_format != nativeIdFormat)
                    break;
            }
            spectrumListForm = new SpectrumListForm(nativeIdFormat);
            spectrumListForm.Text = source.Name + " spectra";
            spectrumListForm.TabText = source.Name + " spectra";
            spectrumListForm.ShowIcon = false;

            spectrumDataProcessing = new DataProcessing();
            
        }

        private SpectrumSource source;
        public SpectrumSource Source { get { return source; } }

        private SpectrumListForm spectrumListForm;
        public SpectrumListForm SpectrumListForm { get { return spectrumListForm; } }

        public DataProcessing spectrumDataProcessing;
        
        public MassSpectrum GetMassSpectrum(int index)
        { return GetMassSpectrum(index, source.MSDataFile.run.spectrumList); }

        public MassSpectrum GetMassSpectrum(int index, SpectrumList spectrumList)
        { return new MassSpectrum(this, index, spectrumList); }

        public MassSpectrum GetMassSpectrum(MassSpectrum metaSpectrum, SpectrumList spectrumList)
        {
            MassSpectrum spectrum = new MassSpectrum(metaSpectrum, spectrumList.spectrum(metaSpectrum.Index, true));
            return spectrum;
        }

        public MassSpectrum GetMassSpectrum(MassSpectrum metaSpectrum, string[] spectrumListFilters)
        {
            var tmp = source.MSDataFile.run.spectrumList;
            try
            {
                SpectrumListFactory.wrap(source.MSDataFile, spectrumListFilters);
                return GetMassSpectrum(metaSpectrum, source.MSDataFile.run.spectrumList);
            }
            finally
            {
                source.MSDataFile.run.spectrumList = tmp;
            }
        }

        public int CompareTo(ManagedDataSource other)
        {
            return String.Compare(source.CurrentFilepath, other.source.CurrentFilepath, StringComparison.Ordinal);
        }
    }
    */
    class mzXMLFileService : IFileService
    {
        public MSData MSDataFile { get; private set; }

        /*Здесь надо написать открытие и считывание mzXML */
    
    
        public List<MassSpectrum> Open(string filename)
        {
            MSDataFile = new MSData();
            // dataSourceMap = new DataSourceMap();
            List<MassSpectrum> spect = new List<MassSpectrum>();
            //ManagedDataSource source = dataSourceMap[filename];
            //source.SpectrumListForm.Close();
            
            
            return spect;
        }
    }
}

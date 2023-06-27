import React from 'react';
import './App.css';
import '@fontsource/roboto/700.css';

/* material components */
import Box from '@mui/material/Box';
import FormControl from '@mui/material/FormControl';
import InputLabel from '@mui/material/InputLabel';
import TextField from '@mui/material/TextField';
import NativeSelect from '@mui/material/NativeSelect';
import Icon from '@mui/material/Icon';
import OutlinedInput from '@mui/material/OutlinedInput';
import Stack from '@mui/material/Stack';
import Button from '@mui/material/Button';
import Grid from '@mui/material/Grid'

/* Custom Components */
import BootstrapInput from './components/BootstrapInput';
/* material colors */
import { green } from '@mui/material/colors';

interface SearchProps {
  search?: string; // required
  committeeType?: string; // optional
}

class App extends React.Component<SearchProps> {
  constructor(props:SearchProps) {
    super(props);

    this.state = {
      search:"",
      committeeType:"",
      base: "https://joesazurefunction.azurewebsites.net/api/",
      url: "/UrlQR.png",
      alt: "QR Code for the Project Wiki",
      age: 30,
      serverError:"",
      cansubmit: false,
      loadingBarClass:'hidden'
    };

    this.handleInputChange = this.handleInputChange.bind(this);
    //this.callService = this.callService.bind(this);
  }
  
  handleInputChange(event: React.ChangeEvent<HTMLInputElement>) {
    const target = event.target;
    const value = target.type === 'checkbox' ? target.checked : target.value;
    const name = target.name;
    this.setState({ [name]: value });
  }
  handleSelectChange(event: React.ChangeEvent<HTMLSelectElement>) {
    const target = event.target;
    const value = target.value;
    const name = target.name;
    this.setState({ [name]: value });
  }
  render() {
    const { search, committeeType} = this.props;
    return(
      <div className="App">
        <header className="App-header">
        
        
        </header>
        <Grid container spacing={2}>
          <Grid item md={6} xs={12}>
            <FormControl sx={{ m:1, width:'100%'}} >
              <InputLabel htmlFor="Search">Search Value</InputLabel>
              <OutlinedInput 
                id="Search"
                name="search"
                value={search}
                label="Search Value"
                />
            </FormControl>
          </Grid>
          <Grid item md={4} xs={8}>
            <FormControl sx={{ m:1, width:'100%' }} >
              <InputLabel htmlFor="CommitteeType">Committee Type</InputLabel>
              <NativeSelect
                id="CommitteeType"
                name="committeeType"
                value={committeeType}
                onChange={this.handleSelectChange}
                input={<OutlinedInput label="Committee Type" />}
                
              >
                <option aria-label="None" value="" />
                <option value="Candidate Campaign Committee">Candidate Campaign Committee</option>
                <option value="Inaugural Committee">Inaugural Committee</option>
                <option value="Out of State Political Committee">Out of State Political Committee</option>
                <option value="Political Action Committee">Political Action Committee</option>
                <option value="Political Party Committee">Political Party Committee</option>
                <option value="Referendum Committee">Referendum Committee</option>
              </NativeSelect>
            </FormControl>
          </Grid>
          <Grid item md={2} xs={4}>
              <Button sx={{ '& button': { p: 2, m: 2 , height:'3.5rem'} }} variant="contained" title="Submit Search" name="SubmitSearch" size="large"><Icon>search</Icon></Button>
          </Grid>
         
        </Grid>
          <Box
            component="form"
            sx={{
              '& .MuiTextField-root': { m: 1, display:'flex', flexDirection: 'row', flexWrap: 'nowrap', alignItems: 'stretch', gap:'1rem',width: '25ch' },
            }}
            noValidate
            autoComplete="off"
          >
              
              
             
              
          </Box>
          <Box
            sx={{
              '& > :not(style)': {
                m: 2,
              },
            }}
          >
          
          </Box>

      </div>
    );
  }
}

export default App;

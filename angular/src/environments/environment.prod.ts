import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'WFCore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44394',
    redirectUri: baseUrl,
    clientId: 'WFCore_App',
    responseType: 'code',
    scope: 'offline_access WFCore',
  },
  apis: {
    default: {
      url: 'https://localhost:44338',
      rootNamespace: 'WFCore',
    },
  },
} as Environment;
